using AdventureQuest.Equipment;
namespace AdventureQuest.Character
{
    public interface ICharacter : IHasInventory, IHasEquipment, IObservable<ICharacter>
    {
        public string Name { get; }
        public string PortraitSpriteKey { get; }
        public Abilities Abilities { get; }
        public int Gold { get; set; }
    }
}