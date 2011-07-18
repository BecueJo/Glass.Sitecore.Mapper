﻿/*
   Copyright 2011 Michael Edwards
 
   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Glass.Sitecore.Mapper
{
    public interface ISitecoreContext : ISitecoreService
    {
        /// <summary>
        /// Retrieves the current item as the specified type
        /// </summary>
        /// <typeparam name="T">The type to return.</typeparam>
        /// <returns>The current item as the specified type</returns>
        T GetCurrentItem<T>() where T : class;

        /// <summary>
        /// Performs a query relative to the current item
        /// </summary>
        /// <typeparam name="T">The type to cast classes to</typeparam>
        /// <returns></returns>
        IEnumerable<T> QueryRelative<T>(string query, bool isLazy, bool inferType) where T : class;

        /// <summary>
        /// Performs a query relative to the current item
        /// </summary>
        /// <typeparam name="T">The type to cast classes to</typeparam>
        /// <returns></returns>
        T QuerySingleRelative<T>(string query, bool isLazy, bool inferType) where T : class;
    }
}
