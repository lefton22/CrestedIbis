using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//һ��α����

public class CrestedIbisAI : MonoBehaviour
{
    //its constant behavior orders
    // if cant find res, just set diff bird with diff personalities
    // diff seasons the priority is diff
    // Ĭ��:safe> eat>mate>breed>rest // represents both priority and the order


    //properties of the bird
    int gender;//1Ϊ�ƣ�2Ϊ��
    int full;// 0��,1��
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



    void order()//��һ�����ģʽ   // should be Sequence,  
    {
        //Ĭ��˳��
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
    void seekForFoodJantoJun(GameObject food)//��ʳ��ˮ���������������ݡ������������Լ����嶯�
                                                            //��̲�����㡢Ϻ���ݡ�з�������ʳ��
    {
        //Ѱ����ʳ��ĵص㣺ˮ���̲��go!
        //�������û�У�Ѱ���еص㣺ˮ���̲��go!
        //����гԵ�,��
    }

    void seekForFoodJuntoNov(GameObject food)//�����ں�̲�����غ������Ե����ʳ�ش����ɢ��
                                                            //��ʳ����Ҫ����򾡢ֱ��Ŀ���棨���󰡢���������з��Ϊ����
    {
        //�ص�:��̲�����ء������Ե
    }

    void goToOpSex()
    //û����ż������(ȥ��)�������q:վ��չʾ��������ë������֦��๻��ഥ����
    //û����ż������(ȥ��)�������q����һֻ�������q: ��������С����ᷢ���������ż��ȹ�����Ϊ��
    //������ż������(ȥ��)�������q����ż��: ��ż��վ��չʾ��ҡͷ���ζ���֦��Ħ��ͷ�����Ϲ����ʺ�ȼ�ǿ��ϵ���ٽ�����ͬ����
    //��ȷ����ż�����Եĺ�֦��: ���䣨ǰ����Ϊ:�����������Ĳ������������໥����Է�ͷ������ë���첻ʱ���໥��ҧ������������ǰ������ż��Ϊ��
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


    //??�Ȳ�Ҫ
    void intimacyPosi()//comb its feather
    {
        //go to the goal
        //if meet the partner
        //if meet the other oppo sex ibis
    }
    //??

    void buildNest()//������Լ��϶����ó��ĵص㣬Ȼ�����q����
                    //����ʳ�ظ�����λ�öԷ�ֳ����ֱ�ӹ�ϵ  (��Ҫ�����غϲ�������)//���������ϾͲ�������
                    //��Ҫ���ϣ�֦���������ٱ�ֲ��
                    //�����أ�������
                    //�����ԣ���������?
    {
    }

    void spawn()//����:����
                //���ѡ�һ����3����Ѯ��3�µײ��ѡ�
                //һ��1-4ö����Ϊ3ö���ѳ���Բ�Σ�������ɫ�������ں�ɫ�ߺͲ����򰵺ֿ�ߡ�
    {
        //isMate = true;
        //һ����3����Ѯ��3�µײ��ѡ�
        //Ѱ�س���
        //gen 1-4 egg, 3's weight is the highest
    }
    void incubate()//���ѡ��첽��������һ����һ������һ�������һ�����5-7�죩��
                   //������25-28�졣���츸ĸ������������
                   //�����ڷ����ھ������ѡ����ѡ������������¶ȱ���37�棩��
                   //ҹ����һֻ���޳��У���һֻ�ڳ�������ҹ�ޡ�
    {
        //���Ѻ�1����ִ��
        //Ѱ����go!
        //����
    }




    void breed()//������������������ȥ��ʳ����������ιʳ��
                //�ճ�����ʱ���������Լ�θ���������Һ״ʳ���µ����������������ʳ
                //ι��ʳ������q�����ѳ���ķ���������
                //�������ǵ��߳�����Ⱦ����֦���ѷ��©�����棬���߰�մ�з������̵��������⣬�ٵ��������ĳ��ĺ��̵��ﲹ�䡣
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
    void verticalMove(int toWhere)//�ε��ڣ�6����Ѯ-11����Ѯ��
                                 //1.�������ߣ����q�����Դ�ֱǨ�ơ���400-600��ƽԭ������Ǩ�ơ�
                                 //2.�Ƿ�ֳ�ڣ���Ⱥ���Ҳ����������һ����
    { 
    }


    void blackKiteComes(GameObject enemy) //������������٣�Ѩ���ǹ�ͬ�ػ���԰ս���е����ǡ�
    {
        //��ʳʱ���м��ʳ���
        //��Ѩ����ʱ��սʤ֮
        //û��Ѩ����ʱ��һ������ս��
    }

    void companiedWithJackdow()//Ѩ�������qһ����ʳ����β�����q��׽�ܾ����ݵ�С��������������q��������ʳ�
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
    void meetSnakeAttackNest()//������������Ϯ���ѻ����
                              //���q���˾��к�����֮�⣬�޿��κΡ�
    {
        //if at the nest + has egg/ baby bird
        //escape screaming
        //egg/baby bird destroyed
    }
    ///breaking
    /////>>>>>>>

}
