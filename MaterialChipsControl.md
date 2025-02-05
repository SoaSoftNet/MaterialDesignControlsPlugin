# MaterialChips & MaterialChipsGroup
Chips are compact elements that represent an input, attribute, or action.
<br/>
[View Material Design documentation](https://material.io/components/chips)

## Screenshot
<img src="https://github.com/HorusSoftwareUY/MaterialDesignControlsPlugin/blob/master/screenshots/chips.gif" width="300">

## Example MaterialChips
```XML
<material:MaterialChips
    IsSelected="true"
    IsEnabled="true"
    Text="Option A"
    BackgroundColor="{StaticResource GradientColorTransparent2}"
    TextColor="{StaticResource GradientColor2}"
    SelectedBackgroundColor="{StaticResource GradientColor2}"
    SelectedTextColor="White" />
```

## Example MaterialChipsGroup
```XML
<material:MaterialChipsGroup
    LabelText="Colors *"
    IsMultipleSelection="True"
    SelectedItems="{Binding SelectedColors}"
    ItemsSource="{Binding Colors}"
    ChipsPadding="16,0"
    ChipsHeightRequest="32"
    BackgroundColor="{StaticResource GradientColorTransparent2}"
    TextColor="{StaticResource GradientColor2}"
    SelectedBackgroundColor="{StaticResource GradientColor2}"
    SelectedTextColor="White"
    LabelTextColor="{StaticResource GradientColor2}"
    AssistiveText="Please select at least 4 colors"
    AssistiveTextColor="Red" />
```
