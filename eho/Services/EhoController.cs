using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eho.Services
{


    public class EhoController
    {
        private string ehoDirection = "恵方の取得に失敗しました。";
        private static string help = "使用法: eho [argument][output option]\n" +
            "\n恵方を応答します。\n" +
             "\nパラメーター：\n\targument:西暦を整数で入力すると対応する恵方を返します。省略した場合は今年の恵方を返します。\n" +
            "\toutput option\t:恵方の出力形式を指定します。\n" +
            "\t※output option一覧※\n" +
            "\t\t/J\t:恵方を8方位の日本語で返します。（例：西南西）\n" +
            "\t\t/J16\t:恵方を16方位の日本語で返します。（例：西南西稍西）\n" +
             "\t\t/J32\t:恵方を32方位の日本語で返します。（例：西微南稍南）";

        //恵方のタイプ
        public enum eho
        {
            WSW, SSE, NNW, ENE, NONE
        }

        //オプション値によって処理を分岐
        public string GetEho(int year, string option)
        {
            var ehoType = ReturnEho(year);
            var ehoWriteing = new EhoWriter();


            switch (option)
            {
                case "NONE":
                    ehoDirection = ehoWriteing.RetrunDirection(ehoType);
                    break;
                case "_J":
                    ehoDirection = ehoWriteing.RetrunDirectionJa(ehoType);
                    break;
                case "_J16":
                    ehoDirection = ehoWriteing.RetrunDirectionJa16(ehoType);
                    break;
                case "_J32":
                    ehoDirection = ehoWriteing.RetrunDirectionJa32(ehoType);
                    break;
                case "_h":
                    ehoDirection = help;
                    break;




            }

            return ehoDirection;
        }


        //恵方を判定
        private eho ReturnEho(int year)
        {

            var ehoType = eho.NONE;

            switch (year % 5)//西暦下一桁 MOD 5
            {
                case 0:
                    ehoType = eho.WSW;
                    break;
                case 1:
                    ehoType = eho.SSE;
                    break;
                case 2:
                    ehoType = eho.NNW;
                    break;
                case 3:
                    ehoType = eho.NNW;
                    break;
                case 4:
                    ehoType = eho.ENE;
                    break;
                default:
                    ehoType = eho.NONE;
                    break;
            }

            return ehoType;

        }



    }
}
