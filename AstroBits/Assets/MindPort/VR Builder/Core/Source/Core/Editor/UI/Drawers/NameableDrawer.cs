// Copyright (c) 2013-2019 Innoactive GmbH
// Licensed under the Apache License, Version 2.0
// Modifications copyright (c) 2021-2022 MindPort GmbH

using System;
using System.Collections.Generic;
using VRBuilder.Core;
using VRBuilder.Core.Behaviors;
using VRBuilder.Core.Conditions;
using VRBuilder.Editor.ProcessValidation;
using UnityEditor;
using UnityEngine;

namespace VRBuilder.Editor.UI.Drawers
{
    /// <summary>
    /// Drawer for values implementing INameable interface.
    /// Instead of drawing a plain text as a label, it draws a TextField with the name.
    /// </summary>
    [DefaultProcessDrawer(typeof(INamedData))]
    public class NameableDrawer : ObjectDrawer
    {
        /// <inheritdoc />
        protected override float DrawLabel(Rect rect, object currentValue, Action<object> changeValueCallback, GUIContent label)
        {
            INamedData nameable = currentValue as INamedData;

            List<EditorReportEntry> reports = GetValidationReports(currentValue);
            if (reports.Count > 0)
            {
                Rect warningRect = rect;
                warningRect.width = 20;
                rect.x += 20;
                GUI.Label(warningRect, AddValidationInformation(new GUIContent(), reports));
            }

            if (currentValue.GetType() != typeof(IStepData))
            {
                DrawName(rect, nameable);
            }
            else
            {
                DrawRenameable(rect, nameable, changeValueCallback);
            }

            return rect.height;
        }

        private void DrawRenameable(Rect rect, INamedData nameable, Action<object> changeValueCallback)
        {
            Rect nameRect = rect;
            nameRect.width = EditorGUIUtility.labelWidth;
            Rect typeRect = rect;
            typeRect.x += EditorGUIUtility.labelWidth;
            typeRect.width -= EditorGUIUtility.labelWidth;

            GUIStyle textFieldStyle = new GUIStyle(EditorStyles.textField)
            {
                fontStyle = FontStyle.Bold,
                fontSize = 12
            };

            string newName = EditorGUI.DelayedTextField(nameRect, nameable.Name, textFieldStyle);
            GUIStyle labelStyle = new GUIStyle(EditorStyles.label)
            {
                fontStyle = FontStyle.Bold,
                fontSize = 12,
                padding = new RectOffset(4, 0, 0, 0)
            };
            EditorGUI.LabelField(typeRect, GetTypeNameLabel(nameable, nameable.GetType()), labelStyle);

            if (newName != nameable.Name)
            {
                string oldName = nameable.Name;
                nameable.Name = newName;
                ChangeValue(() =>
                    {
                        nameable.Name = newName;
                        return nameable;
                    },
                    () =>
                    {
                        nameable.Name = oldName;
                        return nameable;
                    }, changeValueCallback);
            }
        }

        private void DrawName(Rect rect, INamedData nameable)
        {
            GUIStyle labelStyle = new GUIStyle(EditorStyles.label)
            {
                fontStyle = FontStyle.Bold,
                fontSize = 12,
                padding = new RectOffset(4, 0, 0, 0)
            };
            EditorGUI.LabelField(rect, GetTypeNameLabel(nameable, nameable.GetType()), labelStyle);
        }
    }
}
