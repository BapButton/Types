using System;

namespace BAP.Types
{
    /// <summary>
    /// This goes on the class that implements a provider interface
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class BapProviderAttribute : Attribute
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string UniqueId { get; set; }
        public BapProviderAttribute(string name, string description, string uniqueId)
        {
            Name = name;
            Description = description;
            UniqueId = uniqueId;
        }
    }
    /// <summary>
    /// This goes on the Interfaces that define a new type of Provider
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, Inherited = false)]
    public class BapProviderInterfaceAttribute : Attribute
    {
        public bool AllowMultipleInstances { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public BapProviderInterfaceAttribute(string name, string description, bool allowMultipleInstances = false)
        {
            AllowMultipleInstances = allowMultipleInstances;
            Name = name;
            Description = description;
        }
    }


    /// <summary>
    /// This is the entry point for a game. It is the page that you wanted loaded to start the game
    /// This will probably also change once the page is started to show a score or status on the game. 
    /// This must implement IComponent or it cannot be loaded. 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class GamePageAttribute : Attribute
    {
        public string Description { get; set; } = "";
        public string Name { get; set; } = "";
        public string UniqueId { get; set; } = "";
        public GamePageAttribute(string name, string description, string uniqueId = "")
        {
            Name = name;
            Description = description;
            UniqueId = string.IsNullOrEmpty(uniqueId) ? this.GetType().FullName ?? "" : uniqueId;
        }
    }
    /// <summary>
    /// Apply this to a component that you want to show up either in the full app menu or on the side nav. 
    /// Users can choose if it actually shows in the side nav but your suggestion will be honored until overridden by the user.
    /// Make sure you have a page attribute or @page so that there is somewhere to navigate when it is clicked. 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class MenuItemAttribute : Attribute
    {
        public string MouseOverText { get; set; } = "";
        public string DisplayedLabel { get; set; } = "";
        public bool ShowOnMenuByDefault { get; set; } = false;
        public string UniqueId { get; set; } = "";
        public MenuItemAttribute(string displayedLabel, string mouseOverText, bool showOnMenuByDefault = false, string uniqueId = "")
        {
            DisplayedLabel = displayedLabel;
            MouseOverText = mouseOverText;
            ShowOnMenuByDefault = showOnMenuByDefault;
            UniqueId = string.IsNullOrEmpty(uniqueId) ? this.GetType().FullName ?? "" : uniqueId;
        }
    }
    /// <summary>
    /// Apply this to a small component that you want loaded into the top Menu. It must implement IComponent
    /// Most likely it will link to another component when clicked. Give that over page a path attribute or @path component
    /// Then you can navigate to that page using the built in navigation.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class TopMenuAttribute : Attribute
    {

    }
}
