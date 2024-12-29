import os
import re

def parse_solution_files():
    solution_files = []
    for root, _, files in os.walk("."):
        for file in files:
            if file.endswith(".cs"):
                solution_files.append(os.path.join(root, file))
    return solution_files

def extract_problem_info(file_path):
    with open(file_path, "r") as file:
        content = file.read()
        match = re.search(r"https://leetcode.com/problems/([a-zA-Z0-9\-]+)/", content)
        if match:
            url = match.group(0)
            title = match.group(1).replace("-", " ").title()
            return title, url
    return None, None

def generate_solved_problems_list(solution_files):
    solved_problems = []
    for file_path in solution_files:
        title, url = extract_problem_info(file_path)
        if title and url:
            solved_problems.append(f"- [{title}]({url})")
    return solved_problems

def update_readme(solved_problems):
    with open("README.md", "r") as file:
        readme_content = file.read()

    solved_problems_section = "## Solved Problems\n\n" + "\n".join(solved_problems) + "\n"
    updated_readme_content = re.sub(r"## Solved Problems\n\n.*", solved_problems_section, readme_content, flags=re.DOTALL)

    with open("README.md", "w") as file:
        file.write(updated_readme_content)

if __name__ == "__main__":
    solution_files = parse_solution_files()
    solved_problems = generate_solved_problems_list(solution_files)
    update_readme(solved_problems)
