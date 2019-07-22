﻿using System;
using AppKit;
using CoreGraphics;
using Foundation;
using HotUI.Mac.Controls;
using HotUI.Mac.Extensions;

namespace HotUI.Mac.Handlers 
{
	public class ListViewHandler2 : AbstractHandler<ListView, HUITableView>
    {
        public static readonly PropertyMapper<ListView> Mapper = new PropertyMapper<ListView>(ViewHandler.Mapper)
        {
            ["ListView"] = MapListViewProperty
        };

        public ListViewHandler2() : base(Mapper)
        {

        }

        protected override HUITableView CreateView()
        {
            return new HUITableView();
        }

        public override void Remove(View view)
        {
            TypedNativeView.ListView = null;
            base.Remove(view);
        }

        public static void MapListViewProperty(IViewHandler viewHandler, ListView virtualView)
        {
            var nativeView = (HUITableView)viewHandler.NativeView;
            nativeView.ListView = virtualView;
        }
	}
}
