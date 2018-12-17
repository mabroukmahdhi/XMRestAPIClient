﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XMRestAPIClient
{
    /// <summary>
    /// Defines an XMRestService.
    /// </summary>
    /// <typeparam name="T">The model</typeparam>
    public interface IXMDataService<T> where T : IXMModel
    {
        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<T> GetItem(string id);
        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        Task<T> GetItem(Func<T, bool> predicate, int page = -1);
        /// <summary>
        /// Gets all items.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAllItems(int page = -1);
        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        Task<IEnumerable<T>> GetItems(Func<T, bool> predicate, int page = -1);
        /// <summary>
        /// Saves the item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        Task<bool> SaveItem(T item);
        /// <summary>
        /// Deletes the item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        Task<bool> DeleteItem(T item);
        /// <summary>
        /// Deletes the item.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<bool> DeleteItem(string id);
        /// <summary>
        /// Deletes the item.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        Task<bool> DeleteItem(Func<T, bool> predicate);
    }
}

