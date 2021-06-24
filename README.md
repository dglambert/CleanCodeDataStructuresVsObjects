# CleanCodeDataStructuresVsObjects

Motivation: https://blog.cleancoder.com/uncle-bob/2019/06/16/ObjectsAndDataStructures.html
            
## 1
- Classes make functions visible while keeping data implied.
- Data structures make data visible while keeping functions implied.
            
## 2
- Classes make it easy to add types but hard to add functions.
- Data structures make it easy to add functions but hard to add types.
            
## 3
- Data Structures expose callers to recompilation and redeployment.
- Classes isolate callers from recompilation and redeployment.

## Hint:
The use of Hard/Easy is subjective, and can be hard for readers to apply. Instead consider the OCP (Opened/Closed Principal) from SOLID - *"software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification."*
With this definition, consider Hard to mean when you need to Modify existing code, and Easy to be when you do not. 