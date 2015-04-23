// Copyright (c) Rotorz Limited. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root.

using Rotorz.ReorderableList.Internal;
using UnityEditor;
using UnityEngine;

namespace Rotorz.ReorderableList {
	
	/// <summary>
	/// Styles for the <see cref="ReorderableListControl"/>.
	/// </summary>
	public static class ReorderableListStyles {

		static ReorderableListStyles() {
			Title = new GUIStyle();
			Title.border = new RectOffset(2, 2, 2, 1);
			Title.margin = new RectOffset(5, 5, 5, 0);
			Title.padding = new RectOffset(5, 5, 0, 0);
			Title.alignment = TextAnchor.MiddleLeft;
			Title.normal.background = ReorderableListResources.texTitleBackground;
			Title.normal.textColor = EditorGUIUtility.isProSkin
				? new Color(0.8f, 0.8f, 0.8f)
				: new Color(0.2f, 0.2f, 0.2f);

			Container = new GUIStyle();
			Container.border = new RectOffset(2, 2, 1, 2);
			Container.margin = new RectOffset(5, 5, 5, 5);
			Container.padding = new RectOffset(1, 1, 2, 2);
			Container.normal.background = ReorderableListResources.texContainerBackground;

			Container2 = new GUIStyle(Container);
			Container2.normal = GUI.skin.box.normal;
			Container2.border = GUI.skin.box.border;

			AddButton = new GUIStyle();
			AddButton.fixedWidth = 30;
			AddButton.fixedHeight = 16;
			AddButton.normal.background = ReorderableListResources.texAddButton;
			AddButton.active.background = ReorderableListResources.texAddButtonActive;

			AddButton2 = new GUIStyle();
			AddButton2.fixedWidth = 30;
			AddButton2.fixedHeight = 18;
			AddButton2.normal.background = ReorderableListResources.texAddButton2;
			AddButton2.active.background = ReorderableListResources.texAddButton2Active;

			RemoveButton = new GUIStyle();
			RemoveButton.fixedWidth = 27;
			RemoveButton.active.background = ReorderableListResources.CreatePixelTexture("Dark Pixel (List GUI)", new Color32(18, 18, 18, 255));
			RemoveButton.imagePosition = ImagePosition.ImageOnly;
			RemoveButton.alignment = TextAnchor.MiddleCenter;

			var highlightLabelStyle = GUI.skin.FindStyle("Hi Label");
			SelectedItem = new GUIStyle();
			SelectedItem.normal.background = highlightLabelStyle.onActive.background;
			SelectedItem.normal.textColor = Color.white;
			SelectedItem.fontSize = 12;
		}

		/// <summary>
		/// Gets style for title header.
		/// </summary>
		public static GUIStyle Title { get; private set; }

		/// <summary>
		/// Gets style for the background of list control.
		/// </summary>
		public static GUIStyle Container { get; private set; }
		/// <summary>
		/// Gets an alternative style for the background of list control.
		/// </summary>
		public static GUIStyle Container2 { get; private set; }
		/// <summary>
		/// Gets style for add item button.
		/// </summary>
		public static GUIStyle AddButton { get; private set; }
		/// <summary>
		/// Gets an alternative style for add item button 2.
		/// </summary>
		public static GUIStyle AddButton2 { get; private set; }
		/// <summary>
		/// Gets style for remove item button.
		/// </summary>
		public static GUIStyle RemoveButton { get; private set; }

		/// <summary>
		/// Gets style for the background of a selected item.
		/// </summary>
		public static GUIStyle SelectedItem { get; private set; }

	}

}
