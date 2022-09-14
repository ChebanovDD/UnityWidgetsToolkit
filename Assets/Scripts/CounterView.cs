using UnityEngine;
using UnityEngine.UIElements;
using Widgets;

public class CounterView : View<CounterViewModel>
{
    protected override Widget Build(CounterViewModel context)
    {
        return new Scaffold(
            backgroundColor: Color.black,
            body: new SafeArea(
                child: new Stack(
                    children: new Widget[]
                    {
                        new SizedBox(height: 128),
                        new Text(
                            text: context.Header,
                            fontSize: 64,
                            fontColor: Color.white,
                            textAlign: TextAnchor.MiddleCenter
                        ), // Text
                        new Text(
                            text: "Counter prototype",
                            fontSize: 48,
                            fontColor: Color.yellow,
                            textAlign: TextAnchor.MiddleCenter
                        ), // Text
                        new SizedBox(height: 256),
                        new Text(
                            name: "CountText",
                            text: context.Count.ToString(),
                            fontSize: 192,
                            fontColor: Color.white,
                            textAlign: TextAnchor.MiddleCenter
                        ) // Text
                    }
                ) // Stack
            ), // SafeArea
            floatingActionButton: new Stack(
                children: new Widget[]
                {
                    new FloatingActionButton(
                        child: new Icon(Icons.Plus, Color.black),
                        onPressed: () => this.Q<Text>("CountText").SetText((++context.Count).ToString())
                    ), // FloatingActionButton
                    new SizedBox(width: 32, height: 32),
                    new FloatingActionButton(
                        child: new Icon(Icons.Minus, Color.black),
                        onPressed: () => this.Q<Text>("CountText").SetText((--context.Count).ToString())
                    ) // FloatingActionButton
                }
            ) // Stack
        ); // Scaffold
    }

    public new class UxmlFactory : UxmlFactory<CounterView, UxmlTraits> { }
    public new class UxmlTraits : VisualElement.UxmlTraits { }
}