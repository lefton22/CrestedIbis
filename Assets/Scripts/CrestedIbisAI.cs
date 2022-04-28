using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//一张伪代码

public class CrestedIbisAI : MonoBehaviour
{
    //its constant behavior orders
    // if cant find res, just set diff bird with diff personalities
    // diff seasons the priority is diff
    // 默认:safe> eat>mate>breed>rest // represents both priority and the order


    //properties of the bird
    int gender;//1为雌，2为雄
    int full;// 0饿,1饱
    int sprite;//0 need to rest, 1 no need 
    bool isSingle;
    bool isMate;

    void Start()
    {
        full = 1;
        sprite = 1;
        isSingle = true;
        isMate = false;
    }


    void executeMachine()
    {
        
    }



    void order()//需一个设计模式   // should be Sequence,  
    {
        //默认顺序：
        //seekForFoodJantoJun(GameObject food);/ seekForFoodJuntoNov(GameObject food);
        // buildNest();
        // goToOpSex();
        //  intimacyPosi();
        //spawn();
        // incubate();
        // breed();
        // rest();
    }

    ////constant
    ///<<<<<
    void seekForFoodJantoJun(GameObject food)//觅食。水田里有泥鳅、田螺、黄鳝、青蛙以及软体动物。
                                                            //河滩中有鱼、虾、螺、蟹及贝类等食物
    {
        //寻找有食物的地点：水田、河滩，go!
        //如果上面没有，寻找有地点：水田、河滩，go!
        //如果有吃的,吃
    }

    void seekForFoodJuntoNov(GameObject food)//常见于河滩、旱地和塘库边缘（觅食地大而分散）
                                                            //觅食。主要以蚯蚓、直翅目昆虫（如蟋蟀、蝼蛄）、螃蟹等为主。
    {
        //地点:河滩、旱地、塘库边缘
    }

    void goToOpSex()
    //没有配偶，遇到(去找)雌性朱鹮:站立展示，整理羽毛，衔树枝、喙互相触碰。
    //没有配偶，遇到(去找)雌性朱鹮和另一只雄性朱鹮: 遇到“情敌”，会发生争吵、排挤等攻击行为。
    //已有配偶，遇到(去找)雌性朱鹮（配偶）: 求偶。站立展示、摇头、晃动树枝、摩擦头部、鞠躬、问候等加强关系并促进发情同步。
    //已确认配偶，巢旁的横枝上: 交配（前）行为:发出啊啊啊的不连续低鸣；相互梳理对方头部的羽毛，嘴不时地相互逗咬并咕咕低鸣。前面有求偶行为。
    {
        if (gender == 2)
        {
            if (isSingle)
            { 
                //go to the goal
                //if meet female ibis which is single, comb, touch the beaks
                //if meet female ibis which is not single, and her mate is at the same place, battle/quarrel
            }
            if (!isSingle)
            {
                //go to the goal
                //if meet his partner, courtship
                //if meet his comfirmed partner, mate
            }
        }
        if (gender == 1)
        {
            if (isSingle)
            { 
                //if meet male ibis which is single, the male comb, touch the beaks

            }
            if (!isSingle)
            {
                //if meet male ibis which is single, the male battle/quarrel with the partner
                //if meet her partner, the male courtship
                //if meet her comfirmed partner, mate
            }
        }

    }


    //??先不要
    void intimacyPosi()//comb its feather
    {
        //go to the goal
        //if meet the partner
        //if meet the other oppo sex ibis
    }
    //??

    void buildNest()//请玩家自己认定放置巢的地点，然后朱鹮来修
                    //在觅食地附近，位置对繁殖率有直接关系  (需要几个回合才能筑完)//在死规则上就不体现了
                    //需要材料：枝条和少量藤本植物
                    //雄鸟叼回，雌鸟筑
                    //新属性：巢的质量?
    {
    }

    void spawn()//条件:巢中
                //产卵。一般在3月中旬至3月底产卵。
                //一窝1-4枚，多为3枚。卵呈卵圆形，淡青绿色，布有乌褐色斑和不规则暗褐块斑。
    {
        //isMate = true;
        //一般在3月中旬至3月底产卵。
        //寻回巢中
        //gen 1-4 egg, 3's weight is the highest
    }
    void incubate()//孵卵。异步孵化（产一个孵一个，第一个与最后一个相差5-7天）。
                   //孵化期25-28天。白天父母亲轮流孵化。
                   //亲鸟在孵化期经常翻卵、晾卵、理巢（保持卵温度保持37℃）。
                   //夜晚则一只留宿巢中，另一只在巢区附近夜宿。
    {
        //产卵后1个月执行
        //寻巢，go!
        //孵化
    }




    void breed()//育雏：换巢（轮流出去觅食）、护巢、喂食。
                //刚出生的时候，亲鸟用自己胃中消化的黏液状食物吐到雏鸟嘴边让它们吸食
                //喂完食物后，朱鹮亲鸟会把雏鸟的粪便清理掉。
                //清理方法是叼走巢底污染的树枝，把粪便漏到下面，或者把沾有粪便的碎铺垫物叼出巢外，再叼来新来的巢材和铺垫物补充。
    {
        //executed seek for food
        //go to the nest
        //baby bird property
    }
    void rest()
    {
        // go to nest
        // sleep
    }



    /////////constant
    ///>>>>>>>


    ///breaking
    ///////<<<<<
    ///
    void verticalMove(int toWhere)//游荡期（6月下旬-11月上旬）
                                 //1.气温升高，朱鹮季节性垂直迁移。往400-600米平原、丘陵迁移。
                                 //2.非繁殖期，集群生活，也常常和鹭类一起活动。
    { 
    }


    void blackKiteComes(GameObject enemy) //当黑鸢等天敌来临，穴乌是共同守护家园战斗中的主角。
    {
        //觅食时会有几率出现
        //有穴乌在时，战胜之
        //没有穴乌在时，一定几率战败
    }

    void companiedWithJackdow()//穴乌与朱鹮一起觅食，（尾随朱鹮捕捉受惊逃逸的小动物），甚至从朱鹮嘴下抢夺食物。
        //this event happens sometimes with a jackdow, a rate to lose the food
    {
        int rate;
        //gen a jackdow
    }



    void intimacyNeg()//comb its feather
    {
      
        //if meet the partner
        //if meet the other oppo sex ibis
    }
    void meetSnakeAttackNest()//王锦蛇爬上树袭击卵或雏鸟
                              //朱鹮除了惊叫和逃走之外，无可奈何。
    {
        //if at the nest + has egg/ baby bird
        //escape screaming
        //egg/baby bird destroyed
    }
    ///breaking
    /////>>>>>>>

}
