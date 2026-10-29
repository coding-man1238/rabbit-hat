using Godot;
using System;
using System.Web;

public abstract partial class Entity: CharacterBody2D
{
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

    public virtual void OnNoHealth()
    {
        QueueFree();
    }

    private void OnHit(Area2D area)
    {
        GD.Print("collided");
        //implement the damage function later
    }

    public void Heal(float amount) => Health = float.Min(Health + amount, MaxHealth);
}
