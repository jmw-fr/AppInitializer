﻿// <copyright file="IInitializer.cs" company="Weeger Jean-Marc">
// Copyright Weeger Jean-Marc under MIT Licence. See https://opensource.org/licenses/mit-license.php.
// </copyright>

namespace Jmw.AppInitializer
{
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an initialization task.
    /// </summary>
    public interface IInitializer
    {
        /// <summary>
        /// Function performing the initialization Task.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task InitializeAsync();
    }
}
