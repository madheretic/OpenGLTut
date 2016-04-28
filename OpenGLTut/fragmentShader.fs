R"(
#version 330 core

out vec4 color;
uniform float time = 0.0f;
void main()
{
    color = vec4(sin(time), 0.0f, 0.0f, 1.0f);
} 
)"