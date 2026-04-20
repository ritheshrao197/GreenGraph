# Inventory System Design

## Requirements
- Add/remove items
- Stackable items
- Persistence

## Classes
- Inventory
- Item
- Slot

## Relationships
Inventory → List<Slot>
Slot → Item

## Notes
Used composition over inheritance