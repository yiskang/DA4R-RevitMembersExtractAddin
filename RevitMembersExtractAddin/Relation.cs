/////////////////////////////////////////////////////////////////////
// Copyright (c) Autodesk, Inc. All rights reserved
// Written by Forge Partner Development
//
// Permission to use, copy, modify, and distribute this software in
// object code form for any purpose and without fee is hereby granted,
// provided that the above copyright notice appears in all copies and
// that both that copyright notice and the limited warranty and
// restricted rights notice below appear in all supporting
// documentation.
//
// AUTODESK PROVIDES THIS PROGRAM "AS IS" AND WITH ALL FAULTS.
// AUTODESK SPECIFICALLY DISCLAIMS ANY IMPLIED WARRANTY OF
// MERCHANTABILITY OR FITNESS FOR A PARTICULAR USE.  AUTODESK, INC.
// DOES NOT WARRANT THAT THE OPERATION OF THE PROGRAM WILL BE
// UNINTERRUPTED OR ERROR FREE.
/////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;

namespace RevitMembersExtractAddin
{
    class Relation
    {
        public Relation()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Items = new List<RelationItem>();
        }

        /// <summary>
        /// RelationItem Id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Relation Source Filename
        /// <example>House.rvt</example>
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        /// Relation Items
        /// </summary>
        public List<RelationItem> Items { get; set; }
    }

    class RelationItem
    {
        /// <summary>
        /// RelationItem Id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// RelationItem Category
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// RelationItem Type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// RelationItem name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Member Unique Ids
        /// </summary>
        public List<string> MebmerIds { get; set; }
    }
}
