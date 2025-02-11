﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DistinctLogUrlComparer.cs" company="Ilya's company">
//   All rights are reserved
// </copyright>
// <summary>
//   Defines the DistinctLogUrlComparer type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Logger.Helpers
{
    using System.Collections.Generic;

    /// <summary>
    /// The distinct log url comparer.
    /// </summary>
    public class DistinctLogUrlComparer : IEqualityComparer<Log>
    {
        /// <summary>
        /// The equals.
        /// </summary>
        /// <param name="x">
        /// The x.
        /// </param>
        /// <param name="y">
        /// The y.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool Equals(Log x, Log y)
        {
            return y != null && (x != null && x.Url == y.Url);
        }

        /// <summary>
        /// The get hash code.
        /// </summary>
        /// <param name="obj">
        /// The object.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int GetHashCode(Log obj)
        {
            return 1;
        }
    }
}