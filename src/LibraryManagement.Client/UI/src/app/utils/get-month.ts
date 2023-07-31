const today = new Date();

export const currentMonth: string = today.toLocaleString('default', { month: 'long' });