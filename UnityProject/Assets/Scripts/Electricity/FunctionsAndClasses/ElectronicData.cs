using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class ElectronicData  { //to Store data about the electrical device
	
	/// <summary>
	/// Stores for each supply how is the supply connected to that Device.
	/// </summary>
	public Dictionary<ElectricalOIinheritance,HashSet<PowerTypeCategory>> ResistanceToConnectedDevices = new Dictionary<ElectricalOIinheritance,HashSet<PowerTypeCategory>>();

	public Dictionary<int, ElectronicSupplyData> SupplyDependent = new Dictionary<int, ElectronicSupplyData>();
	/// <summary>
	/// The things connected in the vicinity of this
	/// </summary>
	public HashSet<ElectricalOIinheritance> connections = new HashSet<ElectricalOIinheritance> ();
	public int FirstPresent;
	public Electricity ActualCurrentChargeInWire = new Electricity();
	public float UpstreamCount;
	public float DownstreamCount;
	public float CurrentInWire;
	public float ActualVoltage;
	public float EstimatedResistance;
	public float SupplyingCurrent;
	public float InternalResistance;
	public float SupplyingVoltage;
	public bool ChangeToOff;

	public float CurrentStoreValue; //I'm lazy and it's cheaper than making a key value And putting it into a hash set
}
