using Carrot;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Shop : MonoBehaviour
{
    [Header("obj Main")]
    public Game_Handle game;

    private IList<Sprite> list_icon_temp;
    public Item_Obj[] list_Item_Obj;
    public void On_load()
    {
        this.On_load_icon_for_game();
    }

    private void On_load_icon_for_game()
    {
        //this.game.table_fruta.Change_list_icon_fruta(this.Convert_list_sp());
    }

    public void Show()
    {
        this.game.carrot.play_sound_click();
        Carrot_Box box_shop = this.game.carrot.Create_Box();
        box_shop.set_title("Shop");
        box_shop.set_icon(this.game.carrot.icon_carrot_all_category);
        
        foreach (Item_Obj item in this.list_Item_Obj)
        {
            Carrot_Box_Item item_obj = box_shop.create_item("in_app_item");
            item_obj.set_title(item.s_name);
            item_obj.set_icon_white(item.sp_icon);
            item_obj.set_tip(item.s_desc);
            if (item.index_buy == 0)
            {
                item_obj.set_act(() =>
                {
                    this.game.carrot.play_sound_click();
                    this.game.table_fruta.Change_list_icon_fruta(item.sp_items);
                    box_shop.close();
                });
            }
            else
            {
                item_obj.set_act(() =>
                {
                    this.game.carrot.play_sound_click();
                    this.game.carrot.shop.buy_product(item.index_buy);
                });

                Carrot_Box_Btn_Item btn_buy = item_obj.create_item();
                btn_buy.set_icon(this.game.carrot.icon_carrot_buy);
                btn_buy.set_color(this.game.carrot.color_highlight);
                btn_buy.set_icon_color(UnityEngine.Color.white);
                Destroy(btn_buy.GetComponent<Button>());
            }
            
        }
    }
    
    public void OnPaySuccess(string id_p)
    {
        if (id_p ==this.game.carrot.shop.get_id_by_index(0))
        {
            this.game.carrot.Show_msg("Thank you for your support!");
        }else{
            for(int i=0;i<this.list_Item_Obj.Length;i++)
            {
                if (this.game.carrot.shop.get_id_by_index(this.list_Item_Obj[i].index_buy)== id_p)
                {
                    this.list_Item_Obj[i].index_buy= 0;
                    this.game.table_fruta.Change_list_icon_fruta(this.list_Item_Obj[i].sp_items);
                    this.game.carrot.Show_msg("Thank you buying " + this.list_Item_Obj[i].s_name + "!");
                    break;
                }
            }
        }
    }

}
