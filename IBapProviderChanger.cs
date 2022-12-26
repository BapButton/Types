using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAP.Types
{
    public interface IBapProviderChanger
    {
        /// <summary>
        /// Gets the types that implement the provided Bap Provider
        /// </summary>
        /// <typeparam name="T">The type that it needs to implement</typeparam>
        /// <returns>A List of the types and thier details. So they can be listed and then selected</returns>
        public List<(Type loadableType, string uniqueId, string name, string description)> GetAvailableBapProviders<T>() where T : IBapProvider;
        /// <summary>
        /// Update the Bap Provider
        /// </summary>
        /// <typeparam name="T">The type of IBapProvider that is intended to be updated. Like IButtonProvider or ILayoutProvider</typeparam>
        /// <param name="t">This must implement T it will return false.  </param>
        /// <returns>True means it sucesfully updated. False, means it failed to update for any reason.</returns>
        public bool SetNewBapProvider<T>(Type typeOfNewItem) where T : IBapProvider;
        /// <summary>
        /// Update the Bap Provider - this is only for providers types that allow multiple providers
        /// </summary>
        /// <typeparam name="T">The type of IBapProvider that is intended to be add. Like IButtonProvider or ILayoutProvider</typeparam>
        /// <param name="t">This must implement T it will return false.  </param>
        /// <returns>True means it sucesfully updated. False, means it failed to update for any reason.</returns>
        public bool AddBapProvider<T>(Type typeOfNewItem) where T : IBapProvider;
        /// <summary>
        /// Update the Bap Provider- this is only for providers types that allow multiple providers
        /// </summary>
        /// <typeparam name="T">The type of IBapProvider that is intended to be updated. Like IButtonProvider or ILayoutProvider</typeparam>
        /// <param name="t">This must be a implement T or it will return false.  </param>
        /// <returns>True means it sucesfully updated. False, means it failed to update for any reason.</returns>
        public bool RemoveBapProvider<T>(Type typeOfNewItem) where T : IBapProvider;

        /// <summary>
        /// Get Bap Provider- this is only for providers types that allow multiple providers
        /// </summary>
        /// <typeparam name="T">The Parent type of the BapProvider that you want to retrieve like IButtonProvider or ILayoutProvider/typeparam>
        /// <returns>True means it sucesfully updated. False, means it failed to update for any reason.</returns>
        public T? GetCurrentBapProvider<T>() where T : IBapProvider;
    }
}
