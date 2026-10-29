using Godot;
using System;

public partial class Player : Entity
{
    const float SPEED = 10f;

    protected override float MaxHealth => 20f;

    public override void _Process(double delta)
    {
        Vector2 dir = Input.GetVector("left", "right", "up", "down");
        Velocity = dir * SPEED;
    }

    public override void _PhysicsProcess(double delta) => MoveAndSlide();
}
