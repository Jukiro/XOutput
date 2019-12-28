﻿using System.Windows;
using System.Windows.Controls;
using XOutput.Tools;

namespace XOutput.UI.Component
{
    public partial class MappingBlockView : ComponentBase<MappingBlockViewModel, MappingBlockModel, MappingBlockContext>
    {

        [ResolverMethod(Scope.Prototype)]
        public MappingBlockView(MappingBlockViewModel viewModel) : base(viewModel)
        {
            InitializeComponent();
        }

        public override void Initialize(MappingBlockContext context)
        {
            ViewModel.Initialize(context.Controller, context.InputType);
        }

        private void AddInput(object sender, RoutedEventArgs e)
        {
            ViewModel.AddInput();
        }
    }
}