namespace AbstractFactoryL1.AbstractFactoryImpl
{
	/// <summary>
	/// Defines common properties for all vehicle components.
	/// Does not apply to the abstract factory pattern,
	/// is needed to reduce code duplication.
	/// </summary>
	public interface IComponent
	{
		string Name { get; }
		decimal Price { get; }
		double Weight { get; }
	}
}
