﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License

using Microsoft.MixedReality.Toolkit.UI.Interaction;
using UnityEditor;

namespace Microsoft.MixedReality.Toolkit.Editor
{
    /// <summary>
    /// Custom inspector for an InteractiveElement.
    /// </summary>
    [CustomEditor(typeof(InteractiveElement))]
    public class InteractiveElementInspector : BaseInteractiveElementInspector
    {
        protected override void OnEnable()
        {
            base.OnEnable();
        }

        public override void OnInspectorGUI()
        {
            // Interactive Element is a place holder class
            base.OnInspectorGUI();
        }
    }
}
