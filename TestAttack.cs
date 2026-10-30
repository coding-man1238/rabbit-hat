using Godot;
using System;

public partial class TestAttack : Node2D
{
	  const float SPEED = 25f;

	  public Vector2 Dir { set; get; }

	  public override void _PhysicsProcess(double delta)
	  {
			Position += Dir * SPEED * (float)delta;
	  }
}
