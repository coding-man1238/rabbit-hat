using Godot;
using System;

public partial class AttackContainerHolder : HBoxContainer
{
	  public Node2D GetAttackNode(int index)
	  {
			return GetChild<AttackContainer>(index).GetNode();
	  }
}
