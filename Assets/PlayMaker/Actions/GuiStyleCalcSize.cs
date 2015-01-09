// (c) Copyright HutongGames, LLC 2010-2012. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("GUIStyle Calc. Calculate the size of a some content if it is rendered with this style.")]
	public class GuiStyleCalcSize : FsmStateAction
	{
		[RequiredField]
		[Tooltip("Event sent if Float 1 equals Float 2 (within Tolerance)")]
		public FsmString guiStyleName;
		
		[Tooltip("The image of the gui content")]
		public FsmTexture image;
		
		[Tooltip("The text of the gui content")]
		public FsmString text;
		
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The size of the gui content")]
		public FsmVector2 size;
	
		public bool everyFrame;
		
		private GUIStyle _style;
		
		GUIContent	content;
		
		public override void Reset()
		{
			image = null;
			text = null;
			guiStyleName = null;
			
		}

		public override void OnGUI()
		{
			if (_style==null || _style.name !=guiStyleName.Value){
			 _style = new GUIStyle(guiStyleName.Value);
			}
		 	size.Value = _style.CalcSize( new GUIContent(text.Value, image.Value) );
			
			if (!everyFrame)
			{
				Finish ();
			}
		}
	}
}
