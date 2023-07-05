using System;
using Sirenix.OdinInspector;
using UnityEngine;

[Serializable]
public class DonHang : SanPham
{
    public int donHangID;
}

[Serializable]
public class SanPham
{
    [ReadOnly] public int ID;
    public Sprite anh;
    [HideInInspector] public Sprite anhHai;
    [HideInInspector] public string thongTin;
    public string gia;
    public string name;
}