﻿// MvxVisibleTargetBinding.cs

// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System;
using MvvmCross.Binding;
using Windows.UI.Xaml;

namespace MvvmCross.Binding.Uwp.Target
{
    public class MvxVisibleTargetBinding : MvxDependencyPropertyTargetBinding
    {
        public MvxVisibleTargetBinding(object target)
            : base(target, "Visibility", UIElement.VisibilityProperty, typeof(Visibility))
        {
        }

        public override MvxBindingMode DefaultMode => MvxBindingMode.OneWay;

        public override Type TargetType => typeof(bool);

        public override void SetValue(object value)
        {
            if (value == null)
                value = false;
            var boolValue = (bool)value;
            base.SetValue(boolValue ? Visibility.Visible : Visibility.Collapsed);
        }
    }
}