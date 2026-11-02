using Godot;
using System;

public partial class Player : Entity
{
	const float SPEED = 10f;

	public AttackContainerHolder AttackContainer { set; get; }

	protected override float MaxHealth => 20f;

	public override void _Process(double delta)
	{
		Vector2 dir = Input.GetVector("left", "right", "up", "down");
		Velocity = dir * SPEED;
	}

	public override void OnNoHealth()
	{
		GD.Print("died");
	}

	public override void _Input(InputEvent @event)
	{
	  if (@event is InputEventKey event_key && event_key.Pressed)
	  {
			switch (event_key.AsTextKeycode())
			{
				case "1": AttackContainer.GetAttackNode(1); break;
			}
	  }
	}

	public override void _PhysicsProcess(double delta) => MoveAndSlide();
}
