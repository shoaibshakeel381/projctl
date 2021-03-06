﻿namespace Projctl.Core
{
    #region Namespace Imports

    using System.Collections.Generic;

    using Microsoft.Build.Globbing;

    #endregion


    public interface IProject
    {
        string DirectoryPath { get; }
        string FullPath { get; }
        bool IsDirty { get; }
        string Name { get; }

        bool ContainsItems(CompositeGlob items, string[] projectItemTypes = null);
        IEnumerable<IProject> GetReferencedProjects(bool recursive = false);
    }
}