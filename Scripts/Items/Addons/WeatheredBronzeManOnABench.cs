using System;
using Server;

namespace Server.Items
{
    [Flipable(0x9D05, 0x9D07)]
    public class WeatheredBronzeManOnABenchComponent : AddonComponent
    {
        public override int LabelNumber { get { return 1156882; } } // weathered bronze man on a bench sculpture

        public WeatheredBronzeManOnABenchComponent()
            : base(0x9D05)
        {
        }

        public WeatheredBronzeManOnABenchComponent(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadEncodedInt();
        }
    }

    public class WeatheredBronzeManOnABenchAddon : BaseAddon
    {
        public override BaseAddonDeed Deed { get { return new WeatheredBronzeManOnABenchDeed(); } }
        public override bool RetainDeedHue { get { return true; } }

        [Constructable]
        public WeatheredBronzeManOnABenchAddon()
        {
            AddComponent(new WeatheredBronzeManOnABenchComponent(), 0, 0, 0);
        }

        public WeatheredBronzeManOnABenchAddon(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }

    public class WeatheredBronzeManOnABenchDeed : BaseAddonDeed
    {
        public override BaseAddon Addon { get { return new WeatheredBronzeManOnABenchAddon(); } }
        public override int LabelNumber { get { return 1156882; } } // weathered bronze man on a bench sculpture

        [Constructable]
        public WeatheredBronzeManOnABenchDeed()
        {
        }

        public WeatheredBronzeManOnABenchDeed(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}