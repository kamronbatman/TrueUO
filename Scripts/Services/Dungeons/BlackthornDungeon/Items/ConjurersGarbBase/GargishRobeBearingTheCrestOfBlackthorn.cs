namespace Server.Items
{
    public class GargishRobeBearingTheCrestOfBlackthorn7 : GargishRobe
    {
        public override bool IsArtifact => true;

        [Constructable]
        public GargishRobeBearingTheCrestOfBlackthorn7()
        {
            ReforgedSuffix = ReforgedSuffix.Blackthorn;
            Attributes.RegenMana = 2;
            Attributes.DefendChance = 5;
            Attributes.Luck = 140;
            Hue = 1194;
        }

        public GargishRobeBearingTheCrestOfBlackthorn7(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(1);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            reader.ReadInt();
        }
    }
}
