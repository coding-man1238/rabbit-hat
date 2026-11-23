using Godot;
using System;

public abstract partial class Entity : CharacterBody2D
{
	protected abstract float MaxHealth { get; }
	public float Health
	{
		protected set => field = float.Clamp(value, 0, MaxHealth);
		get;
	}

	public override void _Ready()
	{
		Health = MaxHealth;
	}

	public void Damage(float amount)
	{
		Health -= amount;
		if (Health <= 0)
		{
			OnNoHealth();
		}
	}

	public virtual void OnNoHealth()
	{
		QueueFree();
	}

	private void OnHit(Area2D area)
	{
		GD.Print("collided");
		if (area is HitArea hitArea)
		{
			Damage(hitArea.@Damage.Amount);
		}
	}
	public void Heal(float amount) => Health = float.Min(Health + amount, MaxHealth);
}
