using Gallery.Accessability;
using Gallery.Models;
using Gallery.Resources.Styles;
using Gallery.View.Animations;
using Gallery.View.Cells;
using Gallery.View.CommunityMaui;
using Gallery.View.Components.Forms;
using Gallery.View.Components.Mains;
using Gallery.View.Components.Visuals;
using Gallery.View.Layout;
using Gallery.View.Lists;
using Gallery.View.Lists.Models;
using Gallery.View.Shells;
using Gallery.View.Styles;
using Gallery.View.Utils;
using Gallery.View.Utils.Behaviors;

namespace Gallery.Repositories
{
    public partial class GroupComponentRepository : IGroupComponentRepository
    {
        private void LoadData()
        {
            _components = new List<Component>();
            _groupComponents = new List<GroupComponent>();

            LoadLayouts();
            LoadVisuals();
            LoadForms();
            LoadControls();
            LoadCells();
            LoadCollections();
            LoadStyles();
            LoadAnim();
            LoadUtils();
            LoadCommunityMaui();
            LoadShell();
            LoadAccessability();
        }

        private void LoadAccessability()
        {
            var components = new List<Component>
            {
                new Component
                {
                    Name = "Semantic", Description = "Elemento que torna nosso aplicativo visível para quem tem nessecidades especiais.", page = typeof(AccessabilityPage)
                }
            };

            var group = new GroupComponent { Name = "Accessability" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);
        }

        private void LoadShell()
        {
            var components = new List<Component>
            {
                new Component
                {
                    Name = "Shell", Description = "Uma nova forma de estruturar as páginas do projeto.", page = typeof(AppShell), IsReplacementPage = true
                }
            };

            var group = new GroupComponent { Name = "Shell" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);
        }

        private void LoadCommunityMaui()
        {
            var components = new List<Component>
            {
                new Component
                {
                    Name = "SnackBar e Toast", Description = "Formas de emitir alertas/mensagens para o usuário.", page = typeof(AlertPage)
                },
                new Component
                {
                    Name = "Behaviors", Description = "Apresentação de Alguns Behaviors: Masked, StatusBar e EventToCommand(MVVM).", page = typeof(CommunityBehaviorPage)
                },
                new Component
                {
                    Name = "Expander", Description = "Oculta/Apresenta um conteúdo associado a ele.", page = typeof(ExpanderPage)
                },
                new Component
                {
                    Name = "Pop-up", Description = "Apresenta um Modal(Pop-up) na page.", page = typeof(PopupPage)
                },
                new Component
                {
                    Name = "MediaElement", Description = "Player de Mídia (Áudio/Vídio).", page = typeof(MediaElementPage)
                }
            };

            var group = new GroupComponent { Name = ".NET MAUI Community Toolkit" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);
        }

        private void LoadUtils()
        {
            var components = new List<Component>
            {
                new Component
                {
                    Name = "Behavior", Description = "Lógica que pode ser acossiada a um componente da tela.", page = typeof(BehaviorPage)
                },
                new Component
                {
                    Name = "Trigger", Description = "Gatilho que dispara uma alteração visual no componente.", page = typeof(TriggerPage)
                },
                new Component
                {
                    Name = "OnPlataform/OnIdiom", Description = "Define valores diferentes entre o S.O. e tamém pelo tipo de dispositivo.", page = typeof(PlataformIdiomPage)
                },
                new Component
                {
                    Name = "Fontes", Description = "Como utilizar diferentes fontes.", page = typeof(FontPage)
                },
                new Component
                {
                    Name = "Color/Brushes", Description = "Como utilizar as cores nos componentes.", page = typeof(ColorPage)
                }
            };

            var group = new GroupComponent { Name = "Útils" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);
        }

        private void LoadAnim()
        {
            var components = new List<Component>
            {
                new Component
                {
                    Name = "Basic Animation", Description = "Animação Básica do .NET MAUI.", page = typeof(BasicAnimations)
                }
            };

            var group = new GroupComponent { Name = "Animation" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);
        }

        private void LoadStyles()
        {
            var components = new List<Component>
            {
                new Component
                {
                    Name = "Implicit & Explicit Styles", Description = "Funcionamento dos Estilos.", page = typeof(ImplicitExplicitStyles)
                },
                new Component
                {
                    Name = "Global Styles", Description = "Aplica estilo de forma global.", page = typeof(GlobalStyle)
                },
                new Component
                {
                    Name = "ApplyToDerivedTypes", Description = "Aplicar estilos a elementos derivados do controle atual.", page = typeof(ApplyDerivedTypes)
                },
                new Component
                {
                    Name = "InheritanceStyle", Description = "Estilos derivados de outros.", page = typeof(InheritanceStyle)
                },
                new Component
                {
                    Name = "Style Class", Description = "Cria classes de estilos para serem aplicados aos componentes.", page = typeof(StyleClassPage)
                },
                new Component
                {
                    Name = "Static/Dynamic Resources", Description = "Define se o estilo pode ser alterado em tempo real.", page = typeof(StaticDinamicResource)
                },
                new Component
                {
                    Name = "Theme", Description = "Define tema para o projeto.", page = typeof(Tema)
                },
                new Component
                {
                    Name = "AppThemeBinding", Description = "Adapta o tema ao modo claro e escuro do sistema operacional.", page = typeof(AppThemeBindingPage)
                },
                new Component
                {
                    Name = "Visual State Manager", Description = "Personalizar a apresentacao de acordo com o estado do componente.", page = typeof(VSMPage)
                }
            };

            var group = new GroupComponent { Name = "Styles" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);
        }

        private void LoadLayouts()
        {
            var components = new List<Component>
            {
                new Component
                {
                    Name = "StackLayout", Description = "Organização sequencial dos elementos.", page = typeof(StackLayoutPage)
                },
                new Component
                {
                    Name = "Grid", Description = "Organiza em tabelas.", page = typeof(GridLayoutPage)
                },
                new Component
                {
                    Name = "AbsoluteLayout", Description = "Organização livre dos elementos.", page = typeof(AbsoluteLayoutPage)
                },
                new Component
                {
                    Name = "FlexLayout", Description = "Organiza os elementos de forma sequencial com muitas opções de personalização", page = typeof(FlaxLayoutPage)
                }
            };

            var group = new GroupComponent { Name = "Layout" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);
        }

        private void LoadControls()
        {
            var components = new List<Component>
            {
                new Component
                {
                    Name = "BoxView",
                    Description = "Um componente que cria uma caixa para ser apresentada.",
                    page = typeof(BoxViewPage)
                },
                new Component
                {
                    Name = "Label",
                    Description = "Apresenta um texto na tela.",
                    page = typeof(LabelPage)
                },
                new Component
                {
                    Name = "Button",
                    Description = "Apresenta um botão na tela.",
                    page = typeof(ButtonPage)
                },
                new Component
                {
                    Name = "Image",
                    Description = "Apresenta uma imagem na tela.",
                    page = typeof(ImagePage)
                },
                new Component
                {
                    Name = "ImageButton",
                    Description = "Apresenta uma imagem com botão na tela.",
                    page = typeof(ImageButtonPage)
                }
            };

            var group = new GroupComponent { Name = "Controles" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);
        }

        private void LoadVisuals()
        {
            var components = new List<Component> {
                new Component
                {
                    Name = "Frame",
                    Description = "Caixa que envolve outros elementos.",
                    page = typeof(FramePage)
                },
                new Component
                {
                    Name = "Border",
                    Description = "Caixa que envolve outros elementos.",
                    page = typeof(BorderPage)
                },
                new Component
                {
                    Name = "Shadow",
                    Description = "Adiciona borda aos componentes.",
                    page = typeof(ShadowPage)
                }
            };

            var group = new GroupComponent { Name = "Visuais" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);
        }

        private void LoadForms()
        {
            var components = new List<Component> {
                new Component
                {
                    Name = "Entry",
                    Description = "Cria uma caixa de entrada de texto.",
                    page = typeof(EntryPage)
                },
                new Component
                {
                    Name = "Editor",
                    Description = "Cria uma caixa de entrada de texto com múltiplas linhas.",
                    page = typeof(EditorPage)
                },
                new Component
                {
                    Name = "CheckBox",
                    Description = "Cria uma caixa de marcação.",
                    page = typeof(CheckBoxPage)
                },
                new Component
                {
                    Name = "RadioButton",
                    Description = "Cria uma caixa de marcação de escolha única.",
                    page = typeof(RadioButtonPage)
                },
                new Component
                {
                    Name = "Switch",
                    Description = "Cria uma caixa de marcação booleana.",
                    page = typeof(SwotchPage)
                },
                new Component
                {
                    Name = "Stepper",
                    Description = "Cria opções de incrementar ou decrementar valores numérios.",
                    page = typeof(StepperPage)
                },
                new Component
                {
                    Name = "Slider",
                    Description = "Cria barra que incrementa e decrementa um número.",
                    page = typeof(SliderPage)
                },
                new Component
                {
                    Name = "TimePicker",
                    Description = "Permite a seleção de hora e minuto.",
                    page = typeof(TimePickerPage)
                },
                new Component
                {
                    Name = "DatePicker",
                    Description = "Permite a seleção de datas.",
                    page = typeof(DatePickerPage)
                },
                new Component
                {
                    Name = "SearchBar",
                    Description = "Barra de pesquisa.",
                    page = typeof(SearchBarPage)
                },
                new Component
                {
                    Name = "Picker",
                    Description = "Seleciona o item de uma lista.",
                    page = typeof(PickerPage)
                }
            };

            var group = new GroupComponent { Name = "Formulários" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);
        }

        private void LoadCells()
        {
            var components = new List<Component> {
                new Component
                {
                    Name = "TextCell",
                    Description = "Apresenta duas labels onde uma é destinada ao título e outra a descrição.",
                    page = typeof(TextCellPage)
                },
                new Component
                {
                    Name = "ImageCell",
                    Description = "Apresenta uma imagem com duas labels onde uma é destinada ao título e outra a descrição.",
                    page = typeof(ImageCellPage)
                },
                new Component
                {
                    Name = "SwitchCell",
                    Description = "Apresenta uma label em conjunto com um switch.",
                    page = typeof(SwitchCellPage)
                },
                new Component
                {
                    Name = "EntryCell",
                    Description = "Apresenta uma label em conjunto com um entry.",
                    page = typeof(SwitchCellPage)
                },
                new Component
                {
                    Name = "ViewCell",
                    Description = "Permite criar célula com layout personalizado.",
                    page = typeof(ViewCellPage)
                }
            };

            var group = new GroupComponent { Name = "Células" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);
        }

        private void LoadCollections()
        {
            var components = new List<Component> {
                new Component
                {
                    Name = "TableView",
                    Description = "Apresenta células em linhas separadas e permite agrupar por seção.",
                    page = typeof(TableViewPage)
                },
                new Component
                {
                    Name = "Picker",
                    Description = "Apresenta uma lista de seleção única.",
                    page = typeof(PickerListPage)
                },
                new Component
                {
                    Name = "ListView",
                    Description = "Apresenta uma lista de itens.",
                    page = typeof(ListViewPage)
                },
                new Component
                {
                    Name = "CollectionView",
                    Description = "Apresenta uma lista de itens.",
                    page = typeof(CollectionViewPage)
                },
                new Component
                {
                    Name = "CarouselView",
                    Description = "Apresenta uma lista de itens horizontais.",
                    page = typeof(CarouselViewPage)
                },
                new Component
                {
                    Name = "BindableLayout (Atributo)",
                    Description = "Permite que os layouts possam apresentar listas e coleções.",
                    page = typeof(BindableLayoutPage)
                },
                new Component
                {
                    Name = "DataTemplateSelector (Classe)",
                    Description = "Permite que os itens possam ser apresentados com layouts diferentes.",
                    page = typeof(DataTemplateSelectorPage)
                }
            };

            var group = new GroupComponent { Name = "Listas e Coleções" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);
        }
    }
}
