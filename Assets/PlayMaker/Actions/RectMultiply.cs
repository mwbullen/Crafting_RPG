namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Rect)]
	[Tooltip("Multiplies a Rect variable by a Float.")]
	public class RectMultiply : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmRect rectVariable;
		[RequiredField]
		public FsmFloat multiplyBy;
		public bool everyFrame;

		public override void Reset()
		{
			rectVariable = null;
			multiplyBy = 1;
			everyFrame = false;
		}

		public override void OnEnter()
		{
//			var newRect = rectVariable.Value;
//			newRect.Value.x = newRect.x * multiplyBy.Value;
//			rectVariable.Value.width = rectVariable.Value.width * multiplyBy.Value;
//			rectVariable.Value.height = rectVariable.Value.height * multiplyBy.Value;
			
			
			if (!everyFrame)
				Finish();		
		}

		public override void OnUpdate()
		{
//			rectVariable.Value.x = rectVariable.Value.x * multiplyBy.Value;
//			rectVariable.Value.y = rectVariable.Value.y * multiplyBy.Value;
//			rectVariable.Value.width = rectVariable.Value.width * multiplyBy.Value;
//			rectVariable.Value.height = rectVariable.Value.height * multiplyBy.Value;
		}
	}
}

