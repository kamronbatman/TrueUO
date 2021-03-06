namespace Server.Items
{
    public class FemaleKimonoBearingTheCrestOfBlackthorn2 : FemaleKimono
    {
        public override bool IsArtifact => true;

        [Constructable]
        public FemaleKimonoBearingTheCrestOfBlackthorn2()
        {
            ReforgedSuffix = ReforgedSuffix.Blackthorn;
            Attributes.LowerManaCost = 1;
            Attributes.BonusMana = 5;
            Hue = 1306;
        }

        public FemaleKimonoBearingTheCrestOfBlackthorn2(Serial serial)
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
