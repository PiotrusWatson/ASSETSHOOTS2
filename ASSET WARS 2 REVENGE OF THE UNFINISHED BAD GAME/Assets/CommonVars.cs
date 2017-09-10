using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Team{Player,Enemy,Neutral};

public class CommonVars : MonoBehaviour {
	public Team team = Team.Neutral;
}
