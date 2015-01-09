// (c) Copyright HutongGames, LLC 2010-2011. All rights reserved.

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Tests if all the given Integer Variables are are equal to thier Integer States.")]
	public class IntTestMulti : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("This must be the same number used for Integer States.")]
		public FsmInt[] intVariables;
		
		[RequiredField]
		[Tooltip("This must be the same number used for Integer Variables.")]
		public FsmInt[] intStates;
		
		public FsmEvent trueEvent;
		public FsmEvent falseEvent;
		
		[UIHint(UIHint.Variable)]
		public FsmBool storeResult;
		
		public bool everyFrame;

		public override void Reset()
		{
			intVariables = null;
			intStates = null;
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
			if (intVariables.Length == 0 || intStates.Length == 0) return;
			if (intVariables.Length != intStates.Length) return;
				
			bool allTrue = true;
			
			for (int i = 0; i < intVariables.Length; i++) 
			{
				if (intVariables[i].Value != intStates[i].Value)
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