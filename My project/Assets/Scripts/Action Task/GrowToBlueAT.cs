using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class GrowToBlueAT : ActionTask 
	{

		public BBParameter<float> BlueCooldown;
		public BBParameter<float> PurpleCooldown;
		public BBParameter<GameObject> BluePlant;
		public BBParameter<GameObject> Seed;
		public BBParameter<GameObject> PurplePlant;
		

		protected override string OnInit() 
		{
			return null;
		}

		protected override void OnUpdate()
		{
			BlueCooldown.value = 100;
			PurpleCooldown.value -= 10 * Time.deltaTime;
		}
		protected override void OnExecute() 
		{
			
			EndAction(true);
		}
	}
}