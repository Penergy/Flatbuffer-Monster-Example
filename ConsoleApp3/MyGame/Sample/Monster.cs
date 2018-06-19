// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace MyGame.Sample
{

using global::System;
using global::FlatBuffers;

public struct Monster : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Monster GetRootAsMonster(ByteBuffer _bb) { return GetRootAsMonster(_bb, new Monster()); }
  public static Monster GetRootAsMonster(ByteBuffer _bb, Monster obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Monster __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Vec3? Pos { get { int o = __p.__offset(4); return o != 0 ? (Vec3?)(new Vec3()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public short Mana { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetShort(o + __p.bb_pos) : (short)150; } }
  public short Hp { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetShort(o + __p.bb_pos) : (short)100; } }
  public string Name { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(10); }
  public byte Inventory(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.Get(__p.__vector(o) + j * 1) : (byte)0; }
  public int InventoryLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetInventoryBytes() { return __p.__vector_as_arraysegment(14); }
  public Color Color { get { int o = __p.__offset(16); return o != 0 ? (Color)__p.bb.GetSbyte(o + __p.bb_pos) : Color.Blue; } }
  public Weapon? Weapons(int j) { int o = __p.__offset(18); return o != 0 ? (Weapon?)(new Weapon()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int WeaponsLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
  public Equipment EquippedType { get { int o = __p.__offset(20); return o != 0 ? (Equipment)__p.bb.Get(o + __p.bb_pos) : Equipment.NONE; } }
  public TTable? Equipped<TTable>() where TTable : struct, IFlatbufferObject { int o = __p.__offset(22); return o != 0 ? (TTable?)__p.__union<TTable>(o) : null; }

  public static void StartMonster(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddPos(FlatBufferBuilder builder, Offset<Vec3> posOffset) { builder.AddStruct(0, posOffset.Value, 0); }
  public static void AddMana(FlatBufferBuilder builder, short mana) { builder.AddShort(1, mana, 150); }
  public static void AddHp(FlatBufferBuilder builder, short hp) { builder.AddShort(2, hp, 100); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(3, nameOffset.Value, 0); }
  public static void AddInventory(FlatBufferBuilder builder, VectorOffset inventoryOffset) { builder.AddOffset(5, inventoryOffset.Value, 0); }
  public static VectorOffset CreateInventoryVector(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte(data[i]); return builder.EndVector(); }
  public static void StartInventoryVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddColor(FlatBufferBuilder builder, Color color) { builder.AddSbyte(6, (sbyte)color, 2); }
  public static void AddWeapons(FlatBufferBuilder builder, VectorOffset weaponsOffset) { builder.AddOffset(7, weaponsOffset.Value, 0); }
  public static VectorOffset CreateWeaponsVector(FlatBufferBuilder builder, Offset<Weapon>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartWeaponsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddEquippedType(FlatBufferBuilder builder, Equipment equippedType) { builder.AddByte(8, (byte)equippedType, 0); }
  public static void AddEquipped(FlatBufferBuilder builder, int equippedOffset) { builder.AddOffset(9, equippedOffset, 0); }
  public static Offset<Monster> EndMonster(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Monster>(o);
  }
  public static void FinishMonsterBuffer(FlatBufferBuilder builder, Offset<Monster> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedMonsterBuffer(FlatBufferBuilder builder, Offset<Monster> offset) { builder.FinishSizePrefixed(offset.Value); }
};


}
