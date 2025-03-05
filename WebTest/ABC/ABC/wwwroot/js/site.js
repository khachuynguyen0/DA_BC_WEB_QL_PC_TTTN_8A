﻿document.addEventListener("DOMContentLoaded", function(event) {
    // Navigation toggle with smooth animation
    const showNavbar = (toggleId, navId, bodyId, headerId) => {
        const toggle = document.getElementById(toggleId),
              nav = document.getElementById(navId),
              bodypd = document.getElementById(bodyId),
              headerpd = document.getElementById(headerId);

        if (toggle && nav && bodypd && headerpd) {
            toggle.addEventListener('click', () => {
                // Show/hide navbar with animation
                nav.style.transition = 'all 0.3s ease';
                nav.classList.toggle('show');

                // Rotate toggle icon
                toggle.style.transition = 'transform 0.3s ease';
                toggle.style.transform = nav.classList.contains('show') ? 'rotate(90deg)' : 'rotate(0)';
            });
        }
    }

    showNavbar('header-toggle', 'nav-bar', 'body-pd', 'header');

    // Form animations and interactions
    function initializeFormInputs() {
        document.querySelectorAll('.form-control, .form-select').forEach(input => {
            const wrapper = input.closest('.form-floating');
            if (!wrapper) return;

            // Set initial state for filled inputs
            if (input.value || input.tagName === 'SELECT') {
                wrapper.classList.add('filled');
            }

            // Handle focus states
            input.addEventListener('focus', () => {
                wrapper.classList.add('focused');
            });

            input.addEventListener('blur', () => {
                wrapper.classList.remove('focused');
                if (input.value || input.tagName === 'SELECT') {
                    wrapper.classList.add('filled');
                } else {
                    wrapper.classList.remove('filled');
                }
            });

            // Handle change event for selects
            if (input.tagName === 'SELECT') {
                input.addEventListener('change', () => {
                    if (input.value) {
                        wrapper.classList.add('filled');
                    } else {
                        wrapper.classList.remove('filled');
                    }
                });
            }
        });
    }

    // Initialize form interactions
    initializeFormInputs();

    // Form toggle animation
    window.toggleForm = function() {
        const listSection = document.getElementById('listSection');
        const formSection = document.getElementById('formSection');
        
        if (formSection.style.display === 'none') {
            // Show form
            listSection.style.transition = 'all 0.3s ease';
            formSection.style.display = 'block';
            requestAnimationFrame(() => {
                listSection.className = 'col-md-8';
                formSection.classList.add('show');
            });
        } else {
            // Hide form
            listSection.className = 'col-md-12';
            formSection.classList.remove('show');
            formSection.addEventListener('transitionend', () => {
                formSection.style.display = 'none';
            }, { once: true });
        }
    };

    // Table row hover animation
    document.querySelectorAll('.table-hover tr').forEach(row => {
        row.addEventListener('mouseenter', () => {
            row.style.transition = 'all 0.2s ease';
            row.style.transform = 'translateX(5px)';
            row.style.backgroundColor = '#f8fafc';
        });

        row.addEventListener('mouseleave', () => {
            row.style.transform = 'translateX(0)';
            row.style.backgroundColor = '';
        });
    });

    // Button hover effects
    document.querySelectorAll('.btn').forEach(button => {
        button.addEventListener('mouseenter', () => {
            button.style.transition = 'all 0.2s ease';
            if (button.classList.contains('btn-primary')) {
                button.style.transform = 'translateY(-2px)';
                button.style.boxShadow = '0 4px 6px rgba(71, 35, 217, 0.3)';
            }
        });

        button.addEventListener('mouseleave', () => {
            button.style.transform = '';
            button.style.boxShadow = '';
        });
    });

    // Form validation with better feedback
    document.querySelectorAll('form').forEach(form => {
        form.addEventListener('submit', (e) => {
            if (!form.checkValidity()) {
                e.preventDefault();
                e.stopPropagation();

                // Find first invalid field and focus it
                const firstInvalid = form.querySelector(':invalid');
                if (firstInvalid) {
                    firstInvalid.focus();
                    firstInvalid.closest('.form-floating')?.classList.add('invalid');
                }
            }
            form.classList.add('was-validated');
        });

        // Reset validation state on input
        form.querySelectorAll('input, select').forEach(input => {
            input.addEventListener('input', () => {
                const wrapper = input.closest('.form-floating');
                if (wrapper) {
                    wrapper.classList.remove('invalid');
                }
            });
        });
    });
});
