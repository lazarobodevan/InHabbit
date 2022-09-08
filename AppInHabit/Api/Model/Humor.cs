namespace Api.Model {
    public class Humor {
        private string name;
        private string picture { get; set; }
        private HumorType type;

        public Humor() {
            this.SetHumour(HumorType.Happy);
        }

        //TODO: adicionar a imagem de acordo com o humor
        public void SetHumour(HumorType humor) {
            switch (humor){
                case HumorType.SoHappy:
                    //this.picture.set()
                    this.name = "Muito feliz";
                    this.type = humor;
                    break;
                case HumorType.Happy:
                    //this.picture=
                    this.name = "Feliz";
                    this.type = humor;
                    break;
                case HumorType.Love:
                    //this.picture.set()
                    this.name = "Amando";
                    this.type = humor;
                    break;
                case HumorType.Satisfied:
                    //this.picture.set()
                    this.name = "Buxin Xei";
                    this.type = humor;
                    break;
                case HumorType.Angry:
                    //this.picture.set()
                    this.name = "Bolado";
                    this.type = humor;
                    break;
                case HumorType.Crying:
                    //this.picture.set()
                    this.name = "Triste";
                    this.type = humor;
                    break;
                case HumorType.Dead:
                    //this.picture.set()
                    this.name = "Morto";
                    this.type = humor;
                    break;
            }
        }

    }
}
