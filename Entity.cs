using Godot;
using System;

public abstract partial class Entity: CharacterBody2D
{
    private Area2D _hurt_box;

    [Export]
    public Area2D HurtBox
    {
        set {
            _hurt_box.AreaEntered += OnHit;
            _hurt_box = HurtBox;
        }
        get => _hurt_box;
    }

    protected abstract float MaxHealth { get; }
    public float Health { protected set; get; }

    public void Damage(float amount)
    {
        Health -= amount;
        if (Health <= 0)
        {
            //Call relevent functions here
        }
    }

    private void OnHit(Area2D area)
    {
        if ((area.CollisionLayer | 16) != 0)
        {
            GD.Print("collided");
            //implement the damage function later
        }
    }

    public void Heal(float amount) => Health = float.Min(Health + amount, MaxHealth);
}
