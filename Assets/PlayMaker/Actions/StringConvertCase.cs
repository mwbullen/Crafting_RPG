// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.

using UnityEngine;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.String)]
	[Tooltip("Coverts a string to upper or lower case.")]
	public class ConvertCase : FsmStateAction
	{
		public enum Case
		{
			Lower,
			Upper
		}
		
		[RequiredField]
		public FsmString stringVariable;
		
        [Tooltip("Select upper or lower case.")]
		public Case operation = Case.Lower;
		
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString stringValue;
		
		public bool everyFrame;

		public override void Reset()
		{
			stringVariable = null;
			stringValue = null;
			everyFrame = false;
		}

		public override void OnEnter()
		{
			DoSetStringValue();
			
			if (!everyFrame)
				Finish();
		}

		public override void OnUpdate()
		{
			DoSetStringValue();
		}
		
		void DoSetStringValue()
		{
			if (stringVariable == null) return;
			if (stringValue == null) return;
			
			switch (operation)
			{
				case Case.Lower:
					stringValue.Value = stringVariable.Value.ToLower();
					break;

				case Case.Upper:
					stringValue.Value = stringVariable.Value.ToUpper();;
					break;
			}
			
//			stringValue.Value = stringVariable.Value.ToLower();
		}
		
	}
}