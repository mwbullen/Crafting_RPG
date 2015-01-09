// (c) Copyright HutongGames, LLC 2010-2011. All rights reserved.

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Tests if all the given String Variables are are equal to thier String States.")]
	public class StringTestMulti : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("This must be the same number used for String States.")]
		public FsmString[] stringVariables;
		
		[RequiredField]
		[Tooltip("This must be the same number used for String Variables.")]
		public FsmString[] stringStates;
		
		public FsmEvent trueEvent;
		public FsmEvent falseEvent;
		
		[UIHint(UIHint.Variable)]
		public FsmBool storeResult;
		
		public bool everyFrame;

		public override void Reset()
		{
			stringVariables = null;
			stringStates = null;
			trueEvent = null;
			falseEvent = null;
			storeResult = null;
			everyFrame = false;
		}

		public override void OnEnter()
		{
			DoAllTrue();
			
			if (!everyFrame)
				Finish();		
		}
		
		public override void OnUpdate()
		{
			DoAllTrue();
		}
		
		void DoAllTrue()
		{
			if (stringVariables.Length == 0 || stringStates.Length == 0) return;
			if (stringVariables.Length != stringStates.Length) return;
				
			bool allTrue = true;
			
			for (int i = 0; i < stringVariables.Length; i++) 
			{
				if (stringVariables[i].Value != stringStates[i].Value)
				{
					allTrue = false;
					break;
				}
			}
			
			storeResult.Value = allTrue;

			if (allTrue)
				Fsm.Event(trueEvent);
			else
				Fsm.Event (falseEvent);
		}
	}
}