namespace Server.Items
{
    public class ExpiredVoucher : Item
    {
        public override int LabelNumber => 1151749;  // Expired Voucher for a Free Drink at the Fortune's Fire Casino

        [Constructable]
        public ExpiredVoucher()
            : base(0x2831)
        {
        }

        public ExpiredVoucher(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            reader.ReadInt();
        }
    }
}
