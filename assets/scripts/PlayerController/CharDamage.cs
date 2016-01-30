﻿/*
This script represents damage on a player.  It has public functions
to apply damage and/or knockback.
*/
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class CharDamage : MonoBehaviour {
	#region Public Properties

	#endregion
	//--------------------------------------------------------------------------------
	#region Private Properties

	#endregion
	//--------------------------------------------------------------------------------
	#region MonoBehaviour Events
	void Start() {
	
	}
	
	void Update() {
	
	}

	#endregion
	//--------------------------------------------------------------------------------
	#region Public Methods
	
	/// <summary>
	/// Apply some points of damage to the player.  This may cause some flinch/stun
	/// effect, but we can't really do knockback here since we don't know which
	/// direction is "back".  Consider using ApplyDamagePlusKnockback, below.
	/// </summary>
	/// <param name="damage"></param>
	public void ApplyDamage(int damage) {
		Debug.Log(gameObject.name + " takes " + damage + " damage!");
	}
	
	/// <summary>
	/// Apply some points of damage to the player, and also knock him back in
	/// proportion to the amount and length of the given knockback vector.
	/// </summary>
	/// <param name="damage"></param>
	/// <param name="knockback"></param>
	public void ApplyDamagePlusKnockback(int damage, Vector2 knockback) {
		Debug.Log(gameObject.name + " takes " + damage + " damage, plus " + knockback + " knockback!");
	}
	
	#endregion
	//--------------------------------------------------------------------------------
	#region Private Methods

	#endregion
}