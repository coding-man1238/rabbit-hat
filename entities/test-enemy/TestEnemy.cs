using Godot;
using System;

public partial class TestEnemy : Entity
{
    const float SPEED = 5f;

    protected override float MaxHealth => 10f;

    Player player_ref;

    public override void _Ready()
    {
        player_ref = (Player)GetTree().GetFirstNodeInGroup("player");
    }

    public override void _PhysicsProcess(double delta)
    {
        Velocity = GlobalPosition.DirectionTo(player_ref.GlobalPosition) * SPEED;
        MoveAndSlide();
    }
}
