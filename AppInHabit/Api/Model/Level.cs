namespace Api.Model {
    public class Level {
        private string name { get; set; }
        private string picture { get; set; }
        private LevelType type;
        private int totalPercent;
        private int currentPercent;
        private string achievement;

        public Level() { 
        }

        //TODO: adicionar niveis corretamente
        public void SetLevel(LevelType level) {
            switch (level) {
                case LevelType.Beginner:
                    //this.picture = 
                    //this.totalPercent = 
                    this.name = "Iniciante";
                    this.currentPercent = 0;
                    this.achievement = "1 dia completo";
                    break;
                case LevelType.Magician:
                    //this.picture = 
                    //this.totalPercent = 
                    this.name = "Mago da rotina";
                    this.currentPercent = 0;
                    this.achievement = "2 dias completos";
                    break;
                case LevelType.Thief:
                    //this.picture = 
                    //this.totalPercent = 
                    this.name = "Ladrão de cenouras";
                    this.currentPercent = 0;
                    this.achievement = "1 semana completa";
                    break;
                case LevelType.MyCarrot:
                    //this.picture = 
                    //this.totalPercent = 
                    this.name = "Minha cenoura minha vida";
                    this.currentPercent = 0;
                    this.achievement = "2 semanas completas";
                    break;
                case LevelType.Accumulator:
                    //this.picture = 
                    //this.totalPercent = 
                    this.name = "Acumulador";
                    this.currentPercent = 0;
                    this.achievement = "1 mês completo";
                    break;
                case LevelType.Farmer:
                    //this.picture = 
                    //this.totalPercent =
                    this.name = "Cultivador";
                    this.currentPercent = 0;
                    this.achievement = "2 meses completos";
                    break;
                case LevelType.Master:
                    //this.picture = 
                    //this.totalPercent = 
                    this.name = "Mestre da visão";
                    this.currentPercent = 0;
                    this.achievement = "3 meses completos";
                    break;
                case LevelType.WannaCarrot:
                    //this.picture = 
                    //this.totalPercent = 
                    this.name = "Aseita uma senora?";
                    this.currentPercent = 0;
                    this.achievement = "1 dia completo";
                    break;
                case LevelType.Serotonin:
                    //this.picture = 
                    //this.totalPercent = 
                    this.name = "Cenoutonina";
                    this.currentPercent = 0;
                    this.achievement = "6 meses completos";
                    break;
                case LevelType.Business:
                    //this.picture = 
                    //this.totalPercent = 
                    this.name = "Empresário";
                    this.currentPercent = 0;
                    this.achievement = "8 meses completos";
                    break;
                case LevelType.Conqueror:
                    //this.picture = 
                    //this.totalPercent = 
                    this.name = "Conquistador";
                    this.currentPercent = 0;
                    this.achievement = "10 meses completos";
                    break;
                case LevelType.Colonizer:
                    //this.picture = 
                    //this.totalPercent = 
                    this.name = "Conquistador";
                    this.currentPercent = 0;
                    this.achievement = "1 ano completo";
                    break;
            }
        }

    }
}
