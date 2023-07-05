using System.Collections;
using System.Collections.Generic;
using TimDoVat;
using UnityEngine;

public class QuanLyDonHang : Singleton<QuanLyDonHang>
{
    public SanPhamUI sanPham;
    public Transform content;
    
    void Start()
    {
      Refresh();
    }/// <summary>
     /// ///////////
     /// </summary>

    public void Refresh()
    {
        foreach (Transform child in content) {
            GameObject.Destroy(child.gameObject);
        }
        
        var products = GameDataManager.Instance.playerData.donHangs;

        for (int i = 0; i < products.Count; i++)
        {
            var obj = Instantiate(sanPham, content);

          //////
          obj.SetInfo(products[i]);
        }
    }
}
