using Server.Gumps;
using Server.Mobiles;

namespace Server.Engines.VvV
{
    public class ForgedRoyalPardon : Item
    {
        public override int LabelNumber => 1155524;  // Forged Royal Pardon

        [Constructable]
        public ForgedRoyalPardon()
            : base(18098)
        {
            Hue = 0x21;
        }

        public override void OnDoubleClick(Mobile m)
        {
            if (IsChildOf(m.Backpack))
            {
                if (m is PlayerMobile pm && ViceVsVirtueSystem.IsVvV(pm))
                {
                    if (pm.Kills <= 0)
                    {
                        pm.SendMessage("You have no use for this item.");
                    }
                    else if (Spells.SpellHelper.CheckCombat(pm))
                    {
                        pm.SendLocalizedMessage(1116588); //You cannot use a forged pardon while in combat.
                    }
                    else
                    {
                        pm.SendGump(new ConfirmCallbackGump(pm, 1155524, 1155525, null, null, (mobile, obj) =>
                            {
                                mobile.Kills = 0;

                                mobile.Delta(MobileDelta.Noto);

                                mobile.SendMessage("You have been pardoned from all murder counts.");
                                Delete();

                                //TODO: Effects? Message?
                            }));
                    }
                }
                else
                {
                    m.SendLocalizedMessage(1155496); // This item can only be used by VvV participants!
                }
            }
            else
            {
                m.SendLocalizedMessage(1042004); //That must be in your pack for you to use it.
            }
        }

        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);
            list.Add(1154937); // vvv item
        }

        public ForgedRoyalPardon(Serial serial)
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
