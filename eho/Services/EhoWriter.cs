using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eho.Services
{
    public class EhoWriter
    {
        private string ehoDirection = "恵方の取得に失敗しました。";

        //デフォルト
        public string RetrunDirection(EhoController.eho direction)
        {
            switch (direction)
            {
                case EhoController.eho.WSW:
                    ehoDirection = "WSW";
                    break;
                case EhoController.eho.SSE:
                    ehoDirection = "SSE";
                    break;
                case EhoController.eho.NNW:
                    ehoDirection = "NNW";
                    break;
                case EhoController.eho.ENE:
                    ehoDirection = "ENE";
                    break;
                default: break;

            }

            return ehoDirection;
        }

        //日本語
        public string RetrunDirectionJa(EhoController.eho direction)
        {
            switch (direction)
            {
                case EhoController.eho.WSW:
                    ehoDirection = "西南西";
                    break;
                case EhoController.eho.SSE:
                    ehoDirection = "南南東";
                    break;
                case EhoController.eho.NNW:
                    ehoDirection = "北北西";
                    break;
                case EhoController.eho.ENE:
                    ehoDirection = "東北東";
                    break;
                default: break;

            }

            return ehoDirection;
        }
        public string RetrunDirectionJa16(EhoController.eho direction)
        {
            switch (direction)
            {
                case EhoController.eho.WSW:
                    ehoDirection = "西南西稍西";
                    break;
                case EhoController.eho.SSE:
                    ehoDirection = "南南東稍南";
                    break;
                case EhoController.eho.NNW:
                    ehoDirection = "北北西稍北";
                    break;
                case EhoController.eho.ENE:
                    ehoDirection = "東北東稍北";
                    break;
                default: break;

            }

            return ehoDirection;
        }

        public string RetrunDirectionJa32(EhoController.eho direction)
        {
            switch (direction)
            {
                case EhoController.eho.WSW:
                    ehoDirection = "西微南稍南";
                    break;
                case EhoController.eho.SSE:
                    ehoDirection = "南微東稍東";
                    break;
                case EhoController.eho.NNW:
                    ehoDirection = "北微西稍西";
                    break;
                case EhoController.eho.ENE:
                    ehoDirection = "東微北稍北";
                    break;
                default: break;

            }

            return ehoDirection;
        }
    }
}


