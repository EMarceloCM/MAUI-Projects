namespace Gallery.View.Utils.Behaviors
{
    public class AgeValidationBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += OnTextChanged;
            base.OnAttachedTo(bindable);
        }
        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= OnTextChanged;
            base.OnDetachingFrom(bindable);
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var entry = (Entry)sender;
            if (int.TryParse(e.NewTextValue, out int age))
            {
                if(age > 18)
                {
                    entry.TextColor = Colors.Green;
                }
                else
                {
                    entry.TextColor = Colors.Red;
                }
            }
            else
            {
                entry.TextColor = Colors.Yellow;
            }
        }
    }
}
