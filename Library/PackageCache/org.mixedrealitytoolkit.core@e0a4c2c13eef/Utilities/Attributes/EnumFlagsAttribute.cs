﻿// Copyright (c) Mixed Reality Toolkit Contributors
// Licensed under the BSD 3-Clause

using System;
using UnityEngine;

namespace MixedReality.Toolkit
{
    /// <summary>
    /// An attribute that allows a particular field to be rendered as multi-selectable
    /// set of flags.
    /// </summary>
    /// <remarks>
    /// From https://answers.unity.com/questions/486694/default-editor-enum-as-flags-.html
    /// </remarks>
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class EnumFlagsAttribute : PropertyAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumFlagsAttribute"/> class.
        /// </summary>
        public EnumFlagsAttribute() { }
    }
}