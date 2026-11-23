using Godot;

[GlobalClass]
public partial class HitArea : Area2D
{
	  [Export]
	  public Damage @Damage { set; get; }
}
