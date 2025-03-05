def sort_tasks_by_priority(tasks):
    for i in range(1, len(tasks)):  
        key_task = tasks[i]  
        j = i - 1  
        
        while j >= 0 and tasks[j][1] > key_task[1]:  
            tasks[j + 1] = tasks[j]  
            j -= 1  
        
        tasks[j + 1] = key_task  

# قائمة المهام (المهمة، الأولوية)
tasks = [
    ("Complete AI project", 2),
    ("Buy groceries", 3),
    ("Study for exam", 1),
    ("Go to the gym", 2),
    ("Call a friend", 3),
]

# ترتيب المهام بناءً على الأولوية
sort_tasks_by_priority(tasks)

# طباعة المهام بعد الترتيب
print("Sorted To-Do List by Priority:")
for task, priority in tasks:
    print(f"- {task} (Priority: {priority})")
