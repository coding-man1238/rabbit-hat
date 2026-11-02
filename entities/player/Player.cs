using Godot;
using System;

public partial class Player : Entity
{
	const float SPEED = 10f;

	[Export]
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

	void AddAttack(Node2D attack)
	{
		  if (attack is null) return;
		  attack.GlobalPosition = GlobalPosition;
		  attack.Set("Dir", GetLocalMousePosition().Normalized());
		  GetParent().AddChild(attack);
	}

	public override void _Input(InputEvent @event)
	{
	  if (@event is InputEventKey event_key && event_key.Pressed)
	  {
			switch (event_key.AsTextKeycode())
			{
				  case "1": AddAttack(AttackContainer.GetAttackNode(0)); break;
				  case "2": AddAttack(AttackContainer.GetAttackNode(1)); break;
				  case "3": AddAttack(AttackContainer.GetAttackNode(2)); break;
				  case "4": AddAttack(AttackContainer.GetAttackNode(3)); break;
				  case "5": AddAttack(AttackContainer.GetAttackNode(4)); break;
			}
	  }
	}

	public override void _PhysicsProcess(double delta) => MoveAndSlide();
}
